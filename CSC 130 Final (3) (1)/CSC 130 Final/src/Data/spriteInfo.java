package Data;

public class spriteInfo {
    // Fields
        // TODO: Add private class fields to store x, y (use Vector2D for this) and tag (String) values given in class constructor
    private Vector2D coords;
    private String tag;
    
    // Constructor
    public spriteInfo(Vector2D v2d, String tag){
        // TODO: Save the constructor parameters into class fields
        this.coords = v2d;
        this.tag = tag;
    }
    
    // Methods
    public String getTag(){
        // TODO: Remove my placeholder code below (which is there to prevent an error) and replace it with returning the value of your private field tag
        return tag;
    }
    
    public Vector2D getCoords(){
        // TODO: Remove my placeholder code below (which is there to prevent an error) and replace it with returning the value of your private field v2d
        return coords;
    }
    
    public void setTag(String newTag){
        // TODO: Update the value of tag to be the value in newTag (Absolute assignment)
        this.tag = newTag;
    }
    
    public void setCoords(Vector2D newV2D){
        // TODO: Update the value of v2d to be the value in newV2D (Absolute assignment)
        this.coords = newV2D;
    }
    
    public void setCoords(int x, int y){
        // TODO: Overload the setCoords method to allow another way to set the coordinates. Place the x, y integers into v2d by changing the values of v2d to hold x and y (Absolute assignment)
        if (this.coords != null) {
            this.coords.setX(x);
            this.coords.setY(y);
        } else {
            this.coords = new Vector2D(x, y);
        }
    }
    
    public String toString(){
        // TODO: Create a "toString" method to test. Assume an x, y of 100, 50 and a tag of "star", this should return: [100, 50, star]
            // Remove my placeholder code below (which is there to prevent an error) and replace it with your proper toString method with specifications above
        return "[" + coords.getX() + ", " + coords.getY() + ", " + tag + "]";
    }
}
