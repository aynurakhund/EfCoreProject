// See https://aka.ms/new-console-template for more information
using EFCoreProject1.Classes;
using EFCoreProject1.Context;

Console.WriteLine("Hello, World!");


using (StoreContext context = new())
{

    Console.WriteLine("What is Your Status?");
    Console.WriteLine("1.User");
    Console.WriteLine("2.Customer");
    int status = Convert.ToInt32(Console.ReadLine());
    if (status == 1)
    {
        start:

        Console.WriteLine("Our Books:");

        var Bookss = context.Books.Select(x => new
        {
            BookId = x.Id,
            BookName = x.BookName,
            price = x.Price
        }).ToList();

        foreach (var bk in Bookss)
        {
            Console.WriteLine($"Id: {bk.BookId}, BookName:{bk.BookName}, price:{bk.price}");
        }

        Console.WriteLine("Choose The Operation");
        Console.WriteLine("1.Add Book");
        Console.WriteLine("2.Update Book");
        Console.WriteLine("3.Delete Book");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter The Book Name:");
                string bookname = Console.ReadLine();
                Console.WriteLine("Enter The Book Price:");
                int price = Convert.ToInt32(Console.ReadLine());
                var genres = context.Genres.Select(x => new
                {
                    GenreId = x.Id,
                    genre=x.Genrees
                }).ToList();

                foreach (var genre in genres)
                {
                    Console.WriteLine($"id: {genre.GenreId} name: {genre.genre}");
                }

                Console.WriteLine("Enter Genre id of your Book");
                int genreid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Writer Name of Book");
                string NameOfWriter = Console.ReadLine();
                Console.WriteLine("Enter the Writer SurName of Book");
                string SurnameOfWriter = Console.ReadLine();

                Book book = new()
                {
                    BookName=bookname,
                    Price=price,
                    InStock=true,
                    GenreId=genreid,
                    BookWriters=new List<BookWriter>() { new BookWriter() { writers=new Writer() { FirstName=NameOfWriter,LastName=SurnameOfWriter} } }

                };

                context.Add(book);
                context.SaveChanges();
                Console.WriteLine("Added");

                break;
            case 2:
              
                Console.WriteLine("Whoch Book do you want to Update?");
                int updatedBookId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name of Book:");
                string bkName = Console.ReadLine();
                Console.WriteLine("Enter the price of Book:");
                int bkprice = Convert.ToInt32(Console.ReadLine());

                var updatedBook = context.Books.FirstOrDefault(x => x.Id == 1);
                updatedBook.BookName = bkName;
                updatedBook.Price = bkprice;

                context.SaveChanges();
                Console.WriteLine("Updated!");

                break;
            case 3:
              
                Console.WriteLine("Enter the Book Id Which you want to delete");
                int deletedBookId = Convert.ToInt32(Console.ReadLine());

                var deletedBook = context.Books.FirstOrDefault(x => x.Id == deletedBookId);
                context.Books.Remove(deletedBook);
                break;

            default:
                Console.WriteLine("This Type Of Operation does not exist");
                break;
        }

        Console.WriteLine("Do you want to Continue? y or n?");
        char choisenLetter = Convert.ToChar(Console.ReadLine());

        switch(choisenLetter)
        {
            case 'y':
                goto start;
                break;
            case 'n':
                Console.WriteLine("Exit...");
                break;
        }

    }
    else if (status == 2)
    {
        Console.WriteLine("Adding Order");
        Console.WriteLine("Enter Your Order Number");
        int OrderNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter Your Name");
        String Name = Console.ReadLine();
        Console.WriteLine("Please Enter Your SurName");
        String Surname = Console.ReadLine();
        Console.WriteLine("Please Enter Your Address");
        String Adres = Console.ReadLine();

        var Bookss = context.Books.Select(x => new
        {
            BookId = x.Id,
            BookName = x.BookName,
            price = x.Price
        }).ToList();

        foreach (var book in Bookss)
        {
            Console.WriteLine($"Id: {book.BookId}, BookName:{book.BookName}, price:{book.price}");
        }
        Console.WriteLine("Enter Book To you Order");   
        int Bookid = Convert.ToInt32(Console.ReadLine());
        Order order = new()
        {
            OrderNumber=OrderNumber,
            OrderDate= DateTime.Now,
            Customer = new()
            {
                FirstName=Name,
                LastName=Surname,
                Addressess=new() { Addres=Adres}
            },
            OrderBooks=new List<OrderBook>() { new() { BookId=Bookid} }

        };
        context.Add(order);
        context.SaveChanges();
        Console.WriteLine("The Order Added!");

    }
    else
    {
        Console.WriteLine("This type of status does not exist");
    }

}