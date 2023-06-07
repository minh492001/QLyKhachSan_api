package hotel;

public class RoomStandard extends Room{
    public int standard_price;

    public RoomStandard(){}
    public RoomStandard(int standard_price) {
        this.standard_price = standard_price;
    }

    public int getStandard_price() {
        return standard_price;
    }

    public void setStandard_price(int standard_price) {
        this.standard_price = standard_price;
    }
}
