namespace Selector.Model
{
    public abstract class Model
    {
        public int SelectedItemId { get; protected set; }
        
        protected View.View View { get; }
        
        protected Model(View.View view) => View = view;

        public abstract void Select(int selectedItemId);

        public abstract void MoveSelection(int selectedItemId);
    }
}