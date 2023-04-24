using VertexOfQuadratic;

var p1 = new QuadraticCurve();

var answear = p1.Vertex(-1, 0, 25);
Console.WriteLine($"X: {answear[0]}, Y: {answear[1]}");

answear = p1.Vertex(1, 10, 25);
Console.WriteLine($"X: {answear[0]}, Y: {answear[1]}");

answear = p1.Vertex(8, 4, 0);
Console.WriteLine($"X: {answear[0]}, Y: {answear[1]}");