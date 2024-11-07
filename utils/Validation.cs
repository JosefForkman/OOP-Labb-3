public static class Validation
{
    public static bool ValidateHeightWidthIsLessThenZero(double height, double width)
    {
        return height <= 0 && width <= 0;
    }
    public static bool ValidateRadiusIsLessThenZero(double radius)
    {
        return radius <= 0;
    }
}