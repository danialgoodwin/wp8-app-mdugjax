// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ServiceLocator.tt
using WPAppStudio.Ioc;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Container();
        }

        /// <summary>
        /// Gets the reference to a info_InfoViewModel.
        /// </summary>
		public Iinfo_InfoViewModel info_InfoViewModel
        {
            get { return _container.Resolve<info_InfoViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a PhotoAlbum_DetailViewModel.
        /// </summary>
		public IPhotoAlbum_DetailViewModel PhotoAlbum_DetailViewModel
        {
            get { return _container.Resolve<PhotoAlbum_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a upcoming_DetailViewModel.
        /// </summary>
		public Iupcoming_DetailViewModel upcoming_DetailViewModel
        {
            get { return _container.Resolve<upcoming_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a linksAboutThisPlace1ViewModel.
        /// </summary>
		public IlinksAboutThisPlace1ViewModel linksAboutThisPlace1ViewModel
        {
            get { return _container.Resolve<linksAboutThisPlace1ViewModel>(); }
        }
    }
}