namespace Selector.Model
{
    public class SingleSelectModel : Model
    {
        public SingleSelectModel(View.View view) : base(view)
        {
        }

        public override void Select(int selectedItemId)
        {
            View.DeselectThumbnail(SelectedItemId);
            SelectedItemId = selectedItemId;
            View.SelectThumbnail(SelectedItemId);
        }

        public override void MoveSelection(int selectedItemId)
        {
            Select(selectedItemId);
            MoveScroll();
        }

        private void MoveScroll() => View.MoveScroll(SelectedItemId);
    }
}