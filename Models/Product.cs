namespace project_with_dotnet.Models {
    public class ProductVM {
        public string Name { set; get;}
        public double Price {set; get; }

    }

    public class Product : ProductVM {
        public Guid ProductId { set; get; }
        

    }
}
