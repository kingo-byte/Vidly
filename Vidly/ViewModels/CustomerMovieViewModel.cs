using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerMovieViewModel
    {
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
    }
}