import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class Apple {
	public static Random randomGenerator;
	private Point applePoint;
	private Color snakeColor;
	
	public Apple(Snake s) {
		applePoint = createApple(s);
		snakeColor1 = Color.red;		
	}
	
	private Point createApple(Snake s) {
		randomGenerator = new Random();
		int x = randomGenerator.nextInt(30) * 20; 
		int y = randomGenerator.nextInt(30) * 20;
		for (Point snakePoint : s.snakeBody) {
			if (x == snakePoint.X() || y == snakePoint.Y()) {
				return createApple(s);				
			}
		}
		return new Point(x, y);
	}
	
	public void drawApple(Graphics g){
		applePoint.Draw(g, snakeColor);
	}	
	
	public Point point(){
		return applePoint;
	}
}
