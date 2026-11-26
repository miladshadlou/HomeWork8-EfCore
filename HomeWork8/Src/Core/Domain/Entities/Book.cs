namespace HomeWork8.Domain.Entities;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string ISBN { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public int PublisherId { get; set; }

    public Publisher Publisher { get; set; } = null!;

    public bool IsActive { get; set; } = true;

    public string? CoverImageUrl { get; set; }

    public ICollection<BookAuthor> BookAuthors { get; set; }
            = new List<BookAuthor>();

    public ICollection<BookCategory> BookCategories { get; set; }
        = new List<BookCategory>();

    public ICollection<CartItem> CartItems { get; set; }
       = new List<CartItem>();

    public ICollection<OrderItem> OrderItems { get; set; }
    = new List<OrderItem>();

}

