﻿using ElementPlayer.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;

namespace ElementPlayer.Wpf.Pages
{
    [MvxContentPresentation(WindowIdentifier = nameof(MainWindow), StackNavigation = true)]
    public partial class PlayerPage : MvxWpfView<PlayerViewModel>
    {
        public PlayerPage()
        {
            InitializeComponent();
        }
    }
}
