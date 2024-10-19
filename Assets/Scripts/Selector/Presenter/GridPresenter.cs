namespace Selector.Presenter
{
    public class GridPresenter : Presenter
    {
        public GridPresenter(Model.Model model) : base(model)
        {
        }

        public override void OnMoveSelection(int count, int maxCount) => MoveSelection(count, maxCount);

        private void MoveSelection(int count, int maxCount)
        {
            var newId = Model.SelectedItemId + count;

            if (newId < 0)
                newId = 0;
            else if (newId >= maxCount && maxCount > 0)
                newId = maxCount - 1;

            Model.MoveSelection(newId);
        }
    }
}