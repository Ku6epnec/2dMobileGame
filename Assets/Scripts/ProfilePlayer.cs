using Profile;
using Tools;

public class ProfilePlayer
{
    public ProfilePlayer(float speedCar)
    {
        CurrentState = new SubscriptionProperty<GameState>();
        CurrentCar = new Car(speedCar);
    }

    public SubscriptionProperty<GameState> CurrentState { get; }

    public Car CurrentCar { get; }
}

