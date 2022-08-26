using System;

namespace Day_5
{
    class PhotoBook
    {
       protected int numPages;
       
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int _numpages)
        {
            numPages = _numpages;
        }
        public int  GetNumberPages()
        {
            return numPages;
        }
    }

    class BigPhotoBook: PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook1 = new PhotoBook();
            Console.WriteLine(photoBook1.GetNumberPages());

            int numpages = Convert.ToInt32(Console.ReadLine());
            PhotoBook photoBook2 = new PhotoBook(numpages);
            Console.WriteLine(photoBook2.GetNumberPages());

            BigPhotoBook photoBook3 = new BigPhotoBook();
            Console.WriteLine(photoBook3.GetNumberPages());
        }
    }
}
