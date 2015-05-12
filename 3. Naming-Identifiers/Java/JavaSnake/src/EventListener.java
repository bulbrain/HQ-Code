import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class eventListener implements KeyListener{
	
	public eventListener(Game game){
		game.addKeyListener(this);
	}
	
	public void keyPressed(KeyEvent e) {
		int KeyCode = e.getKeyCode();
		
		if (KeyCode == KeyEvent.VK_W || KeyCode == KeyEvent.VK_UP) {
			if(Game.snake.getVelY() != 20){
				Game.snake.setVelX(0);
				Game.snake.setVelY(-20);
			}
		}
		if (KeyCode == KeyEvent.VK_S || KeyCode == KeyEvent.VK_DOWN) {
			if(Game.snake.getVelY() != -20){
				Game.snake.setVelX(0);
				Game.snake.setVelY(20);
			}
		}
		if (KeyCode == KeyEvent.VK_D || KeyCode == KeyEvent.VK_RIGHT) {
			if(Game.snake.getVelX() != -20){
			Game.snake.setVelX(20);
			Game.snake.setVelY(0);
			}
		}
		if (KeyCode == KeyEvent.VK_A || KeyCode == KeyEvent.VK_LEFT) {
			if(Game.snake.getVelX() != 20){
				Game.snake.setVelX(-20);
				Game.snake.setVelY(0);
			}
		}

		//Other controls
		if (KeyCode == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}
}
