using System;
using ListView;
using Syncfusion.Maui.ListView;

namespace ListView
{
    #region Behavior
    public class Behaviour : Behavior<ContentPage>
    {
        #region Fields
        private SfListView listView;
        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            listView = bindable.FindByName<SfListView>("listView");
           // listView.SelectionController = new SelectionControllerExt(listView);
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            listView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion
    }
    #endregion

    #region ItemGeneratorExt
    public class ItemGeneratorExt:ItemsGenerator
    {
        public ItemGeneratorExt(SfListView listview) : base(listview)
        {

        }
        protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
        {
            if (type == ItemType.Record)
                return new ListViewItemExt();
            return base.OnCreateListViewItem(itemIndex, type, data);
        }
    }
    #endregion

    #region ListViewItemExt
    public class ListViewItemExt : ListViewItem
    {
        public ListViewItemExt()
        {
        }

        protected override void OnItemAppearing()
        {
            var item = this.BindingContext as BookInfo;
            if (!item.IsAnimated)
            {
                this.Opacity = 0;
                this.FadeTo(1, 400, Easing.SinInOut);
                item.IsAnimated = true;
            }
            base.OnItemAppearing();
        }
    }
    #endregion


    //public class SelectionControllerExt : SelectionController
    //{
    //    public SelectionControllerExt(SfListView listView) : base(listView)
    //    {
    //    }

    //    protected async override void AnimateSelectedItem(ListViewItem selectedListViewItem)
    //    {
    //        base.AnimateSelectedItem(selectedListViewItem);
    //        selectedListViewItem.Opacity = 0;
    //        selectedListViewItem.FadeTo(1, 3000, Easing.SinInOut);

    //        //await selectedListViewItem.ScaleTo(0.95, 500, Easing.SinInOut);
    //        //await selectedListViewItem.ScaleTo(1, 500, Easing.SinInOut);
    //    }
    //}
}

