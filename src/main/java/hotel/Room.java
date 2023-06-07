package hotel;

public class Room {
    private int room_id;
    private boolean status;

    public Room() {
    }

    public Room(int room_id, boolean status) {
        this.room_id=room_id;
        this.status=status;
    }

    public void setRoom_id(int room_id) {
        this.room_id = room_id;
    }

    public int getRoom_id() {
        return room_id;
    }

    public void setStatus(boolean status) {
        this.status = status;
    }

    public boolean getStatus() {
        return status;
    }
}
