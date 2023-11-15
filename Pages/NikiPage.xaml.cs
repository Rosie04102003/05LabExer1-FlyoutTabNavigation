namespace FlyoutTabNavPrefi.Pages;

public partial class NikiPage : ContentPage
{
    String NikiPageText = "This is one of the works of Niki. ";

    String NikiAlbum = "On August 2022, she released Nicole. " +
        "In that album, she wrote my favorite song called Oceans and Engines.";

    String NikiFavorite = "Oceans and Engine talks about letting go. " +
        "How, despite not wanting to, we have to let go of our clutches " +
        "on things that do not work for us anymore.";
    public NikiPage()
	{
		InitializeComponent();
        ChangeNikiLabel();
	}

    public void ChangeNikiLabel()
    {
        nikiText.Text = NikiPageText;
        nikiAlbum.Text = NikiAlbum;
        nikiFavorite.Text = NikiFavorite;
    }
}