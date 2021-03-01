using UnityEngine;

namespace Old
{
    public abstract class ActionBase
    {
        public ICommand Command => command;
        public Sprite Sprite => sprite;

        protected ICommand command;
        protected Sprite sprite;
    }
}