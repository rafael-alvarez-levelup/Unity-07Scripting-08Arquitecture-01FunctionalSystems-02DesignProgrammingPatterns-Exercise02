using UnityEngine;

namespace Old
{
    public class EnemySlotController : SlotControllerBase
    {
        private IResolveTurnEventHandler turnResolver;

        protected override void Awake()
        {
            myAgent = GameObject.Find("Enemy");
            targetAgent = GameObject.Find("Player");

            turnResolver = GameObject.Find("ButtonEnd").GetComponent<IResolveTurnEventHandler>();

            base.Awake();
        }

        private void OnEnable()
        {
            turnResolver.OnResolveTurn += EndButtonController_OnResolveTurn;
        }

        private void OnDisable()
        {
            turnResolver.OnResolveTurn -= EndButtonController_OnResolveTurn;
        }

        private void EndButtonController_OnResolveTurn()
        {
            ResolveAction();
        }

        private void ResolveAction()
        {
            ChangeAction(GetRandomIndex());
        }

        private int GetRandomIndex()
        {
            int randomIndex = Random.Range(0, actions.Length);
            return randomIndex;
        }
    }
}