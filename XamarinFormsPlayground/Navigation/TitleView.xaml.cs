using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsPlayground.Navigation
{
    public partial class TitleView : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(object), typeof(TitleView), null, BindingMode.OneWay, null, null, null, null, null);
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty LeftImageSourceProperty = BindableProperty.Create("LeftImageSource", typeof(ImageSource), typeof(ImageSource), null, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(TitleView.OnLeftImageSourceChanged), null, null, null);
        public ImageSource LeftImageSource
        {
            get { return (ImageSource)GetValue(LeftImageSourceProperty); }
            set { SetValue(LeftImageSourceProperty, value); }
        }

        public static readonly BindableProperty LeftImageCommandProperty = BindableProperty.Create("LeftImageCommand", typeof(ICommand), typeof(ICommand), null, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(TitleView.OnLeftImageCommandChanged), null, null, null);
        public ICommand LeftImageCommand
        {
            get { return (ICommand)GetValue(LeftImageCommandProperty); }
            set { SetValue(LeftImageCommandProperty, value); }
        }

        public static readonly BindableProperty RightImageSourceProperty = BindableProperty.Create("RightImageSource", typeof(ImageSource), typeof(ImageSource), null, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(TitleView.OnRightImageSourceChanged), null, null, null);
        public ImageSource RightImageSource
        {
            get { return (ImageSource)GetValue(RightImageSourceProperty); }
            set { SetValue(RightImageSourceProperty, value); }
        }

        public static readonly BindableProperty RightImageCommandProperty = BindableProperty.Create("RightImageCommand", typeof(ICommand), typeof(ICommand), null, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(TitleView.OnRightImageCommandChanged), null, null, null);
        public ICommand RightImageCommand
        {
            get { return (ICommand)GetValue(RightImageCommandProperty); }
            set { SetValue(RightImageCommandProperty, value); }
        }

        public static readonly BindableProperty ProgressIsVisibleProperty = BindableProperty.Create("ProgressIsVisible", typeof(object), typeof(TitleView), false, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(TitleView.OnProgressIsVisibleChanged), null, null, null);
        public bool ProgressIsVisible
        {
            get { return (bool)GetValue(ProgressIsVisibleProperty); }
            set { SetValue(ProgressIsVisibleProperty, value); }
        }

        public static readonly BindableProperty ProgressProperty = BindableProperty.Create("Progress", typeof(object), typeof(TitleView), 0, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(TitleView.OnProgressChanged), null, null, null);
        public double Progress
        {
            get { return (double)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        public TitleView()
        {
            InitializeComponent();

            ProgressView.IsVisible = false;
        }

        private static void OnLeftImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var titleView = (TitleView)bindable;

            titleView.LeftImage.Source = newValue as ImageSource;
        }

        private static void OnLeftImageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var titleView = (TitleView)bindable;

            if (newValue != null)
            {
                var tapGesture = new TapGestureRecognizer { Command = newValue as ICommand };

                titleView.LeftImage.GestureRecognizers.Clear();
                titleView.LeftImage.GestureRecognizers.Add(tapGesture);
                titleView.LeftImage.IsVisible = true;
            }
        }

        private static void OnRightImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var titleView = (TitleView)bindable;

            titleView.RightImage.Source = newValue as ImageSource;
        }

        private static void OnRightImageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var titleView = (TitleView)bindable;

            if (newValue != null)
            {
                var tapGesture = new TapGestureRecognizer { Command = newValue as ICommand };

                titleView.RightImage.GestureRecognizers.Clear();
                titleView.RightImage.GestureRecognizers.Add(tapGesture);
            }
        }

        private static void OnProgressIsVisibleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var titleView = (TitleView)bindable;

            if (newValue != null)
            {
                titleView.ProgressView.IsVisible = bool.Parse(newValue.ToString().ToLower());
            }
        }

        private static void OnProgressChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var titleView = (TitleView)bindable;

            if (newValue != null)
            {
                titleView.ProgressView.Progress = double.Parse(newValue.ToString());
            }
        }
    }
}
