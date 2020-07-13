using MLEM.Startup;

namespace FarmGame {
    public class GameImpl : MlemGame {

        public static GameImpl Instance { get; private set; }

        public GameImpl() {
            Instance = this;
        }

    }
}