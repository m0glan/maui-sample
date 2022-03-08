using MauiSample.Core.Facade;
using System.ComponentModel;
using static MauiSample.Core.Domain;

namespace MauiSample
{
    public interface IMainPageViewModel : INotifyPropertyChanged
    {
        IEnumerable<Product> Products { get; }
    }

    public class MainPageViewModel : IMainPageViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IProductService _productService;
        public IEnumerable<Product> Products 
        {
            get => _productService.GetProducts();
        }

        public MainPageViewModel(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }
    }
}
