// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.Touch.Views;
using News.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace News.iOS.Views
{
    public partial class CategoryView : MvxViewController<CategoryViewModel>
	{
        public CategoryView () : base ("CategoryView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            Title = ViewModel.Title;

            var source = new MvxStandardTableViewSource (TableView, "TitleText Title");
            TableView.Source = source;

            var set = this.CreateBindingSet<CategoryView, CategoryViewModel> ();
            set.Bind (TableView).For ("Visibility").To (vm => vm.ArticleSummaries).WithConversion ("Visibility");
            set.Bind (ActivityIndicator).For ("Visibility").To (vm => vm.ArticleSummaries).WithConversion ("InvertedVisibility");
            set.Bind (source).To (vm => vm.ArticleSummaries);
            set.Bind (source).For (s => s.SelectionChangedCommand).To (vm => vm.ItemSelected);
			set.Apply ();
        }

        public override void ViewWillAppear (bool animated)
        {
            base.ViewWillAppear (animated);
            TableView.DeselectRow (TableView.IndexPathForSelectedRow, true);
        }
	}
}
