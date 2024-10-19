namespace Selector.Presenter
{
    public abstract class Presenter
    {
        protected Model.Model Model { get; }

        protected Presenter(Model.Model model) => Model = model;

        public void OnThumbnailSelected(int id) => Model.Select(id);

        public abstract void OnMoveSelection(int count, int maxCount);
    }
}