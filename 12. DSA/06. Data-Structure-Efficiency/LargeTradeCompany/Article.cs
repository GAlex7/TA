namespace LargeTradeCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Article : IComparable<Article>
    {
        public Article(string barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0}| {1,8}| {2,10} | {3,10:F2}", this.Barcode, this.Vendor, this.Title, this.Price);
        }
    }
}
