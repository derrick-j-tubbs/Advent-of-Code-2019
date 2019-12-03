using System;
using System.Collections.Generic;
using System.Drawing;

namespace Advent_of_Code_2019 {
   
    public class AOC2019_Day3 {
        //Used HashSet's for part one, converted to dictionaries for part 2
        //HashSet<Point> wireMap1 = new HashSet<Point>();
        //HashSet<Point> wireMap2 = new HashSet<Point>();
        Dictionary<Point, int> wireMap1 = new Dictionary<Point, int>();
        Dictionary<Point, int> wireMap2 = new Dictionary<Point, int>();
        List<int> taxicabDistances = new List<int>();

        public void mapCollisions (string[] wire1, string[] wire2) {
            //used the intersects with function of hashsets to find the collisions in part 1
            wireMap1 = mapWire(wire1);
            wireMap2 = mapWire(wire2);
            //wireMap1.IntersectWith(wireMap2);
            //taxicabDistances = findTaxicabDistances(wireMap1);
            List<int> collisionSteps = findCollisions(wireMap1, wireMap2);
            int shortestSteps = findShortestSteps(collisionSteps);
            Console.WriteLine($"Shortest total steps is is { shortestSteps }");
            //Console.WriteLine($"Shortest taxicab distance is { findShortestTaxicabDistance(taxicabDistances) }");
        }

        public Dictionary<Point, int> mapWire(string[] wire) {
            int x = 0;
            int y = 0;
            int stepsTraveled = 0;
            Dictionary<Point, int> wireMap = new Dictionary<Point, int>();
            foreach ( var connection in wire) {
                var direction = connection[0];
                var distance = 0;
                if (!Int32.TryParse(connection.Substring(1), out distance)){
                    distance = 0;
                }
                for (int i = 0; i < distance; i++) {
                    switch (direction) {
                        case 'U':
                            y++;
                            break;
                        case 'D':
                            y--;
                            break;
                        case 'R':
                            x++;
                            break;
                        case 'L':
                            x--;
                            break;
                        default:
                            break;
                    }
                    Point point = new Point(x, y);
                    stepsTraveled++;
                    if (!wireMap.TryAdd(point, stepsTraveled)) {
                        if(stepsTraveled < wireMap[point]) {
                            wireMap[point] = stepsTraveled;
                        }
                    }
                }
            }
            return wireMap;
        }
        public List<int> findCollisions (Dictionary<Point, int> wireMap1, Dictionary<Point, int> wireMap2) {
            List<int> collisions = new List<int>();
            foreach (KeyValuePair<Point, int> collision in wireMap1) {
                if (wireMap2.ContainsKey(collision.Key)) {
                    collisions.Add(collision.Value + wireMap2[collision.Key]);
                }
            }
            return collisions;
        }

        public int findShortestSteps (List<int> stepList) {
            int shortestSteps = stepList[0];
            foreach (int steps in stepList) {
                if (steps < shortestSteps) {
                    shortestSteps = steps;
                }
            }
            return shortestSteps;
        }

        /* public List<int> findTaxicabDistances (Dictionary<Point, int> collisions) {
            List<int> taxicabDistances = new List<int>();
            foreach(var collision in collisions) {
                int taxicabDistance = Math.Abs(collision.X) + Math.Abs(collision.Y);
                taxicabDistances.Add(taxicabDistance);
            }
            return taxicabDistances;
        } */

        public int findShortestTaxicabDistance (List<int> taxicabDistances) {
            int shortestTaxicabDistance = 10000000;
            foreach (int distance in taxicabDistances) {
                if (distance < shortestTaxicabDistance) {
                    shortestTaxicabDistance = distance;
                }
            }
            return shortestTaxicabDistance;
        }
    }

   /*  public class Point {
        public int x;
        public int y;

        public Point(int _x, int _y) {
            x = _x;
            y = _y;
        }
        
        // override object.Equals
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Point);
        }
        
        public bool Equals(Point point) {
            if (Object.ReferenceEquals(point, null)) {
                return false;
            }

            if (Object.ReferenceEquals(this, point)) {
                return true;
            }

            if (this.GetType() != point.GetType()) {
                return false;
            }

            return (x == point.x) && (y == point.y);
        }

        public override int GetHashCode()
        {
            return (x << 2) ^ y;
        }
    } */
}