// EnemyController.cs (version 2)
using UnityEngine; // Inserted for completeness
public interface IEnemyState {
    void EnterState(EnemyController controller);
    void UpdateState();
}

public class PatrolState : IEnemyState {
    public void EnterState(EnemyController controller) {
        controller.SetPatrolBehavior();
    }

    public void UpdateState() {
        // Patrol logic here
    }
}

public class AttackState : IEnemyState {
    public void EnterState(EnemyController controller) {
        controller.SetAttackBehavior();
    }

    public void UpdateState() {
        // Attack logic here
    }
}

public class EnemyController : MonoBehaviour {
    private IEnemyState currentState;

    public void SetState(IEnemyState newState) {
        currentState = newState;
        currentState.EnterState(this);
    }

    void Update() {
        currentState.UpdateState();
    }

    public void SetPatrolBehavior() {
        // Specific patrol settings
    }

    public void SetAttackBehavior() {
        // Specific attack settings
    }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.