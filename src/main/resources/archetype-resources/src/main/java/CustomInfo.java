package Customer;
public class CustomInfo {
    private int customer_id;
    private String name;
    private String address;
    private String phone_number;
    private String day_check_in;
    private String day_check_out;


    public CustomInfo() {
    }

    public CustomInfo(int customer_id, String name, String address, String phone_number, String day_check_in, String day_check_out){
        this.customer_id=customer_id;
        this.name=name;
        this.address=address;
        this.phone_number=phone_number;
        this.day_check_in=day_check_in;
        this.day_check_out=day_check_out;
    }

    public int getCustomer_id() {
        return customer_id;
    }

    public void setCustomer_id(int customer_id) {
        this.customer_id = customer_id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getPhone_number() {
        return phone_number;
    }

    public void setPhone_number(String phone_number) {
        this.phone_number = phone_number;
    }

    public String getDay_check_in() {
        return day_check_in;
    }

    public void setDay_check_in(String day_check_in) {
        this.day_check_in = day_check_in;
    }

    public String getDay_check_out() {
        return day_check_out;
    }

    public void setDay_check_out(String day_check_out) {
        this.day_check_out = day_check_out;
    }
}
