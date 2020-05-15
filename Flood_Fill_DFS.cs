using System;
namespace c__programming
{
  public class Flood
  {
    public int[][] FloodFILL(int[][] image, int sr, int sc, int newColor)
    {
      var oldColor = image[sr][sc];
      var rowMax = image.Length - 1;
      var colMax = image[0].Length - 1;

      if (oldColor != newColor) DFS(sr, sc);
      return image;

      void DFS(int row, int col)
      {
        if (row < 0 || rowMax < row ||
           col < 0 || colMax < col ||
           image[row][col] != oldColor) return;

        image[row][col] = newColor;

        DFS(row - 1, col);
        DFS(row + 1, col);
        DFS(row, col - 1);
        DFS(row, col + 1);
      }
    }
  }
}