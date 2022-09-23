namespace PhotoAlbum;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Photo Album Exercise below:");
        Console.WriteLine("*******************************");

        var album = new PhotoAlbum();

        Console.WriteLine($"The PhotoAlbum created is called: {album.name} and it has {album.nrPages} pages!");

        Console.WriteLine("*******************************");

        var album1 = new BigPhotoAlbum();

        var albumPages = album1.nrPages = 64;
        var albumName = album1.name = "Memories";

        Console.WriteLine($"The new BigPhotoAlbum created is called: {albumName} and it has: {albumPages} pages!");

        Console.WriteLine("*******************************");

        var testAlbum = new AlbumTest();

        
        Console.WriteLine($"This is an album created by class TestAlbum and it's default name is: {testAlbum.name} and it's default number of pages is: {testAlbum.nrPages} pages!");


        Console.WriteLine();

    }

    public class PhotoAlbum
    {
       public int nrPages;
       public string name;

        public PhotoAlbum()
        {
            nrPages = 16;
            name = "Album";
        }

        public PhotoAlbum(int nrPages, string name)
        {
            this.nrPages = nrPages;
            this.name = name;
        }

        public int GetNumberOfPages(int nrPages)
        {
            return nrPages;
        }
    }

    class BigPhotoAlbum
    {
        public int nrPages { get; set; }
        public string name { get; set; }

        public BigPhotoAlbum(int nrPages, string name)
        {
            this.nrPages = nrPages;
            this.name = name;
        }

        public BigPhotoAlbum()
        {
        }
    }

    class AlbumTest : BigPhotoAlbum
    {
        public AlbumTest()
        {

        }
    }
}