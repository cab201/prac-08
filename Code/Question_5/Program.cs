using System.Diagnostics.CodeAnalysis;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo(4, 3);
            Photo mattedPhoto = new MattedPhoto(8, 4, "black");
            Photo framedPhoto = new FramedPhoto(12, 9, "wooden", "classical");

            Photo otherFramedPhoto = new FramedPhoto(12, 9, "wooden", "classical");

            Console.WriteLine(framedPhoto.Equals(otherFramedPhoto));

            //Photo[] photos = { photo, mattedPhoto, framedPhoto };

            //foreach (Photo p in photos)
            //{
            //    Console.WriteLine(p);
            //    p.DisplayPhoto();
            //}
        }
    }
}