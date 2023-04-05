public class Singleton {

    private static final int addThreeCards = 3;
    private int card;
    private static Deck instance = new Deck(); 

    private Deck() {
        instance = this;
    }

    public static Number getInstance() {
        return instance;
    }

    public int getNumber() {
        return card;
    }

    public void addMoreCards() {
        card += addThreeCards;
    }

    public void deductCards() {
        card--;
    }
}