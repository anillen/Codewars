public class BouncingBall {
	
    public static int bouncingBall(double h, double bounce, double window) {
        if(h<=0 || bounce <= 0 || bounce >=1 || window >= h)
            return -1;
        int count = -1;
      
        while(h > window)
        {
            h *= bounce;
            count+=2;
        }

        return count;
    }
}