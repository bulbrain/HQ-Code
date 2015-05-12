import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

public class Snake{
	LinkedList<Point> snakeBody = new LinkedList<Point>();
	private Color snakeColor;
	private int velocityX, velocityY;
	
	public Game() {
		snakeColor = Color.GREEN;
		snakeBody.add(new Point(300, 100)); 
		snakeBody.add(new Point(280, 100)); 
		snakeBody.add(new Point(260, 100)); 
		snakeBody.add(new Point(240, 100)); 
		snakeBody.add(new Point(220, 100)); 
		snakeBody.add(new Point(200, 100)); 
		snakeBody.add(new Point(180, 100));
		snakeBody.add(new Point(160, 100));
		snakeBody.add(new Point(140, 100));
		snakeBody.add(new Point(120, 100));

		velocityX = 20;
		velocityY = 0;
	}
	
	public void drawSnake(Graphics g) {		
		for (Point point : this.snakeBody) {
			point.Draw(g, snakeBody);
		}
	}
	
	public void tick() {
		Point newPointPos = new Point((snakeBody.get(0).X() + velocityX), 
		(snakeBody.get(0).Y() + velocityY));
		
		if (newPointPos.X() > Core.WIDTH - 20) {
		 	Core.gameRunning = false;
		} else if (newPointPos.X() < 0) {
			Core.gameRunning = false;
		} else if (newPointPos.Y() < 0) {
			Core.gameRunning = false;
		} else if (newPointPos.Y() > Core.height - 20) {
			Core.gameRunning = false;
		} else if (Core.apple.point().equals(newPointPos)) {
			snakeBody.add(Core.apple.point());
			Core.apple = new Apple(this);
			Core.points += 50;
		} else if (snakeBody.contains(newPointPos)) {
			Core.gameRunning = false;
			System.out.println("You ate yourself");
		}	
		
		for (int i = snakeBody.size()-1; i > 0; i--) {
			snakeBody.set(i, new Point(snakeBody.get(i-1)));
		}	
		snakeBody.set(0, newPointPos);
	}

	public int getVelX() {
		return velocityX;
	}

	public void setVelX(int velX) {
		this.velocityX = velX;
	}

	public int getVelY() {
		return velocityY;
	}

	public void setVelY(int velY) {
		this.velocityY = velY;
	}
}
