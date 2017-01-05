using Android.Widget;

namespace BeaconAGH.Android
{
    public partial class MainActivity
    {
        #region Data Info Properties

        private EditText _idEditText;
        public EditText IdEditText => _idEditText ?? (_idEditText = FindViewById<EditText>(Resource.Id.idEditText));

        private EditText _rangeEditText;
        public EditText RangeEditText => _rangeEditText ?? (_rangeEditText = FindViewById<EditText>(Resource.Id.rangeEditText));

        private EditText _timestampEditText;
        public EditText TimestampEditText => _timestampEditText ?? (_timestampEditText = FindViewById<EditText>(Resource.Id.timestampEditText));

        private EditText _delayEditText;
        public EditText DelayEditText => _delayEditText ?? (_delayEditText = FindViewById<EditText>(Resource.Id.delayEditText));

        #endregion

        #region Request Data Button Properties

        private Button _getDataOneButton;
        public Button GetDataOneButton => _getDataOneButton ?? (_getDataOneButton = FindViewById<Button>(Resource.Id.getDataOneButton));

        private Button _getDataTwoButton;
        public Button GetDataTwoButton => _getDataTwoButton ?? (_getDataTwoButton = FindViewById<Button>(Resource.Id.getDataTwoButton));

        #endregion
    }
}