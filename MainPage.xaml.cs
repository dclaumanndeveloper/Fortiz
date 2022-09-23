using Fortiz.Views;

namespace Fortiz;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void NR01_Clicked(object sender, EventArgs e)
    {
        // try
        // {
        //  Uri uri = new Uri(" https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/nr-1");
        //  await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
         
        await Navigation.PushAsync(new NR01());
    }

    private async void NR02_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-2-nr-2");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }

    private async void NR03_Clicked(object sender, EventArgs e)
    {
        // try
        // {
        //     Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-3-nr-3");
        //     await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        // }
        // catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        // }
        await Navigation.PushAsync(new NR03());
    }

    private async void NR04_Clicked(object sender, EventArgs e)
    {
        // try
        // {
        //     Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-4-nr-4");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR04());
    }

    private async void NR05_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-5-nr-5");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR05());
    }

    private async void NR06_Clicked(object sender, EventArgs e)
    {
        // try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-6-nr-6");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR06());
    }

    private async void NR07_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-7-nr-7");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR07());
    }

    private async void NR08_Clicked(object sender, EventArgs e)
    {

        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-8-nr-8");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR08());
    }

    private async void NR09_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //  Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-9-nr-9");
        //  await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.

        //}
        await Navigation.PushAsync(new NR09());
    }
    private async void NR10_Clicked(object sender, EventArgs e)
    {
        // try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-10-nr-10");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR10());
    }

    private async void NR11_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-11-nr-11");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        // }
        await Navigation.PushAsync(new NR11());
    }

    private async void NR12_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-12-nr-12");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR12());
    }

    private async void NR13_Clicked(object sender, EventArgs e)
    {
        // try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-13-nr-13");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR13());
    }

    private async void NR14_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-14-nr-14");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        // }
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        // }
        //await Navigation.PushAsync(new NR14());
    }

    private async void NR15_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-15-nr-15");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR15());
    }

    private async void NR16_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-16-nr-16");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR16());
    }

    private async void NR17_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-17-nr-17");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR17());
    }

    private async void NR18_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-18-nr-18");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR18());
    }

    private async void NR19_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-19-nr-19");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR19());
    }

    private async void NR20_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-20-nr-20");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR20());
    }

    private async void NR21_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-21-nr-21");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
       // await Navigation.PushAsync(new NR21());
    }

    private async void NR22_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-22-nr-22");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR22());
    }

    private async void NR23_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-23-nr-23");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR23());
    }

    private async void NR24_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-24-nr-24");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        //await Navigation.PushAsync(new NR24());
    }

    private async void NR25_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-25-nr-25");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR25());
    }

    private async void NR26_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-26-nr-26");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR26());
    }

    private async void NR27_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-27-nr-27");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
       // await Navigation.PushAsync(new NR27());
    }

    private async void NR28_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-28-nr-28");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR28());
    }

    private async void NR29_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-29-nr-29");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR29());
    }

    private async void NR30_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-30-nr-30");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR30());
    }

    private async void NR31_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-31-nr-31");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR31());
    }

    private async void NR32_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-32-nr-32");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR32());
    }

    private async void NR33_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-33-nr-33");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR33());
    }

    private async void NR34_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-34-nr-34");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}
        await Navigation.PushAsync(new NR34());
    }

    private async void NR35_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-35-nr-35");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}

        await Navigation.PushAsync(new NR35());
    }

    private async void NR36_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-36-nr-36");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}

        await Navigation.PushAsync(new NR36());
    }

    private async void NR37_Clicked(object sender, EventArgs e)
    {
        //try
        //{
        //    Uri uri = new Uri("https://www.gov.br/trabalho-e-previdencia/pt-br/composicao/orgaos-especificos/secretaria-de-trabalho/inspecao/seguranca-e-saude-no-trabalho/ctpp-nrs/norma-regulamentadora-no-37-nr-37");
        //    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //}
        //catch (Exception ex)
        //{
        // An unexpected error occured. No browser may be installed on the device.
        //}

        await Navigation.PushAsync(new NR37());
    }
}

