[System.Serializable]
public class ProgressData 
{
    public int Coins;
    public int Level;
    public float[] BackgroundColor;
    public bool IsMusicOn;

    public ProgressData(Progress progress)
    {
        Coins= progress.Coins;
        Level= progress.Level;
        BackgroundColor = new float[3];
        BackgroundColor[0] = progress.BackgroundColor.r;
        BackgroundColor[0] = progress.BackgroundColor.g;
        BackgroundColor[0] = progress.BackgroundColor.b;

        IsMusicOn= progress.IsMusicOn;
    }
}
