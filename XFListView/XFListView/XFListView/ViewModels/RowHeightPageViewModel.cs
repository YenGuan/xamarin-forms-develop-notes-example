﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XFListView.Repositories;
using Prism.Navigation;

namespace XFListView.ViewModels
{
    public class RowHeightPageViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<MyItemViewModel> myItemList;
        public ObservableCollection<MyItemViewModel> MyItemList
        {
            get { return myItemList; }
            set { SetProperty(ref myItemList, value); }
        }



        private MyItemViewModel myItemListSelected;
        public MyItemViewModel MyItemListSelected
        {
            get { return myItemListSelected; }
            set { SetProperty(ref myItemListSelected, value); }
        }

        public DelegateCommand 可變列高Command { get; private set; } 
        public DelegateCommand 固定列高Command { get; private set; } 
        public RowHeightPageViewModel()
        {
            MyItemList = MyItemRepository.SampleLongViewModel();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
