// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of FreshCoffee_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class FreshCoffee_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IFreshCoffee_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.FreshCoffee_FreshCoffee _freshCoffee_FreshCoffee;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="FreshCoffee_DetailViewModel" /> class.
        /// </summary>
        /// <param name="freshCoffee_FreshCoffee">The Fresh Coffee_ Fresh Coffee.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public FreshCoffee_DetailViewModel(Repositories.FreshCoffee_FreshCoffee freshCoffee_FreshCoffee, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_freshCoffee_FreshCoffee = freshCoffee_FreshCoffee;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.FreshCoffeeSchema _currentFreshCoffeeSchema;

        /// <summary>
        /// CurrentFreshCoffeeSchema property.
        /// </summary>		
        public Entities.FreshCoffeeSchema CurrentFreshCoffeeSchema
        {
            get
            {
				return _currentFreshCoffeeSchema;
            }
            set
            {
                SetProperty(ref _currentFreshCoffeeSchema, value);
            }
        }
	
		private bool _hasNextpanoramaFreshCoffee_Detail0;

        /// <summary>
        /// HasNextpanoramaFreshCoffee_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaFreshCoffee_Detail0
        {
            get
            {
				return _hasNextpanoramaFreshCoffee_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaFreshCoffee_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaFreshCoffee_Detail0;

        /// <summary>
        /// HasPreviouspanoramaFreshCoffee_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaFreshCoffee_Detail0
        {
            get
            {
				return _hasPreviouspanoramaFreshCoffee_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaFreshCoffee_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechFreshCoffee_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechFreshCoffee_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentFreshCoffeeSchema.Subtitle + " " + CurrentFreshCoffeeSchema.Description);
        }
		

        private ICommand _textToSpeechFreshCoffee_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechFreshCoffee_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechFreshCoffee_DetailStaticControlCommand
        {
            get { return _textToSpeechFreshCoffee_DetailStaticControlCommand = _textToSpeechFreshCoffee_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechFreshCoffee_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareFreshCoffee_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareFreshCoffee_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentFreshCoffeeSchema.Subtitle, CurrentFreshCoffeeSchema.Description, "", CurrentFreshCoffeeSchema.Image);
        }
		

        private ICommand _shareFreshCoffee_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareFreshCoffee_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareFreshCoffee_DetailStaticControlCommand
        {
            get { return _shareFreshCoffee_DetailStaticControlCommand = _shareFreshCoffee_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareFreshCoffee_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartFreshCoffee_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartFreshCoffee_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IFreshCoffee_DetailViewModel), CreateTileInfoFreshCoffee_DetailStaticControl());
        }
		

        private ICommand _pinToStartFreshCoffee_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartFreshCoffee_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartFreshCoffee_DetailStaticControlCommand
        {
            get { return _pinToStartFreshCoffee_DetailStaticControlCommand = _pinToStartFreshCoffee_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartFreshCoffee_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaFreshCoffee_Detail0 command.
        /// </summary>
        public  void NextpanoramaFreshCoffee_Detail0Delegate() 
        {
			var next =  _freshCoffee_FreshCoffee.Next(CurrentFreshCoffeeSchema);

			if(next != null)
				CurrentFreshCoffeeSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaFreshCoffee_Detail0;

        /// <summary>
        /// Gets the NextpanoramaFreshCoffee_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaFreshCoffee_Detail0
        {
            get { return _nextpanoramaFreshCoffee_Detail0 = _nextpanoramaFreshCoffee_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaFreshCoffee_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaFreshCoffee_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaFreshCoffee_Detail0Delegate() 
        {
			var prev =  _freshCoffee_FreshCoffee.Previous(CurrentFreshCoffeeSchema);

			if(prev != null)
				CurrentFreshCoffeeSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaFreshCoffee_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaFreshCoffee_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaFreshCoffee_Detail0
        {
            get { return _previouspanoramaFreshCoffee_Detail0 = _previouspanoramaFreshCoffee_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaFreshCoffee_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaFreshCoffee_Detail0 = _freshCoffee_FreshCoffee.HasPrevious(CurrentFreshCoffeeSchema);
			HasNextpanoramaFreshCoffee_Detail0 = _freshCoffee_FreshCoffee.HasNext(CurrentFreshCoffeeSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.FreshCoffeeSchema)) { return; }
                
                CurrentFreshCoffeeSchema = value as Entities.FreshCoffeeSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the FreshCoffee_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoFreshCoffee_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentFreshCoffeeSchema.Id.ToString(),
                Title = CurrentFreshCoffeeSchema.Subtitle,
                BackTitle = CurrentFreshCoffeeSchema.Subtitle,
                BackContent = CurrentFreshCoffeeSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentFreshCoffeeSchema.Image,
                BackBackgroundImagePath = CurrentFreshCoffeeSchema.Image,
                LogoPath = "Item-ad3f659b-9662-4640-abfe-7aafef7dbd05.png"
            };
            return tileInfo;
        }
    }
}
