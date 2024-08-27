using DlibDotNet;
using DlibDotNet.Extensions;
using OpenCvSharp;
using OpenCvSharp.Extensions;

using Size = System.Drawing.Size;

namespace FaceSwapWinform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // load the input image
            var bitmap = Bitmap.FromFile("./input.jpg") as Bitmap;

            // load the face to swap
            var bitmapToSwap = Bitmap.FromFile("./selfie.jpg") as Bitmap;

            // process image
            var newBitmap = ProcessImage(bitmap!, bitmapToSwap!);

            // show new image
            outputPicBox.Image = newBitmap;
        }

        private static Bitmap ProcessImage(Bitmap image, Bitmap newImage)
        {
            // set up Dlib facedetectors and 
            using var fd = Dlib.GetFrontalFaceDetector();
            using var sp = ShapePredictor.Deserialize("./shape_predictor_68_face_landmarks.dat");

            // convert image to dlib format
            //var compatibleImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), PixelFormat.Format24bppRgb);
            var img = image.ToArray2D<RgbPixel>();

            // find target's faces in image
            var faces = fd.Operator(img);
            var target = faces[1];

            // get target's landmark points
            var targetShape = sp.Detect(img, target);
            var targetPoints = (from i in Enumerable.Range(0, (int)targetShape.Parts)
                                let p = targetShape.GetPart((uint)i)
                                select new OpenCvSharp.Point(p.X, p.Y)).ToArray();

            // get convex hull of target's points
            var hull = Cv2.ConvexHullIndices(targetPoints);
            var targetHull = from i in hull
                             select targetPoints[i];

            // find landmark points in face to 
            var imgMark = newImage.ToArray2D<RgbPixel>();
            var faces2 = fd.Operator(imgMark);
            var source = faces2[0];
            var sourceShape = sp.Detect(imgMark, source);
            var sourcePoints = (from i in Enumerable.Range(0, (int)sourceShape.Parts)
                                let p = sourceShape.GetPart((uint)i)
                                select new OpenCvSharp.Point(p.X, p.Y)).ToArray();

            // get convex hull of source's points
            var hull2 = Cv2.ConvexHullIndices(targetPoints);
            var sourceHull = from i in hull2
                             select sourcePoints[i];

            // calculate Delaunay triangles
            var triangles = Utility.GetDelaunayTriangles(targetHull);

            // get transformations to warp the new face onto target's face
            var warps = Utility.GetWarps(sourceHull, targetHull, triangles);

            // apply the warps to the new face to prep it for insertion into the main image
            var warpedImg = Utility.ApplyWarps(newImage, image.Width, image.Height, warps);

            // prepare a mask for the warped image
            var mask = new Mat(image.Height, image.Width, MatType.CV_8UC3);
            mask.SetTo(0);
            Cv2.FillConvexPoly(mask, targetHull, new Scalar(255, 255, 255), LineTypes.Link8);

            // find the center of the warped face
            var r = Cv2.BoundingRect(targetHull);
            var center = new OpenCvSharp.Point(r.Left + r.Width / 2, r.Top + r.Height / 2);

            // blend the warped face into the main image
            var selfie = BitmapConverter.ToMat(image);
            var blend = new Mat(selfie.Size(), selfie.Type());
            Cv2.SeamlessClone(warpedImg, selfie, mask, center, blend, SeamlessCloneMethods.NormalClone);

            // return the modified main image
            return BitmapConverter.ToBitmap(blend);
        }
    }
}
