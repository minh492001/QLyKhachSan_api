package hotel;

public class RoomLuxury extends Room{
    public int luxury_price;

    public RoomLuxury() {}
    public RoomLuxury(int luxury_price){
        this.luxury_price=luxury_price;
    }

    public int getLuxury_price() {
        return luxury_price;
    }

    public void setLuxury_price(int luxury_price) {
        this.luxury_price = luxury_price;
    }
}
