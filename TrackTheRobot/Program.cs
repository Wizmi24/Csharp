using TrackTheRobot;

var robot = new Tracking();

var position = robot.TrackRobot("up 40", "down 10", "right 30", "left 20");
Console.WriteLine("Horizontally: "+position[0,0]+ " Vertically: " + position[1,0]);

var robot2 = new Tracking();

position = robot2.TrackRobot("up 10", "down 30", "right 20", "left 70");
Console.WriteLine("Horizontally: " + position[0, 0] + " Vertically: " + position[1, 0]);

var robot3 = new Tracking();

position = robot3.TrackRobot("up 40", "down 40", "right 30", "left 30");
Console.WriteLine("Horizontally: " + position[0, 0] + " Vertically: " + position[1, 0]);