# DwVideo
Programa que nos permitir� descargar videos de Youtube.

## Paquetes NuGet usados:
- YoutubeExplode 6.5.4
- Magick.NET-Q16-AnyCPU 14.6.0

## PrincipalMain
En este podemos encontrar los componentes importantes:

| Componente					 | Funcion																							     |
|--------------------------------|-------------------------------------------------------------------------------------------------------|
| search_input					 | Aqui podemos agregar la url de descarga.														         |
| Search						 | Este boton inicia el proceso de descarga.														     |
| activities					 | Aqui se agrega una nueva instancia del componente Video.											     |
| ResolutionOption				 | Selector donde se puede especificar la resolucion del video.										     |
| TypeOption					 | Selector donde se puede especificar entre Audio y Video, si es Audio se deshabilita ResolutionOption. |
| menu							 | Menu superior del programa.																		     |
| rutaDeDescargaToolStripMenuItem| Aqui puede especificar la ruta de descarga del video.												 |

### Funciones 

#### TypeOption_SelectedIndexChanged

Esta funcion habilita y deshabilita el componente ResolutionOption. Donde en el caso de seleccionar Audio se deshabilita el ResolutionOption.
```C#
private void TypeOption_SelectedIndexChanged(object sender, EventArgs e)
{
    if(TypeOption.SelectedItem.ToString() == "Audio")
    {
        ResolutionOption.Enabled = false;
    }
    else
    {
        ResolutionOption.Enabled = true;
    }
}
```


#### Search_Click

Esta funcion inicia el proceso de descarga del componente de Video. Pero primero se valida si estan disponibles los datos para que no ocurran excepciones.
```C#
private void Search_Click(object sender, EventArgs e)
{
    Search.Enabled = false;
    if (search_input.Text != "")
    {
        Video video_component = new Video(search_input.Text, DownloadPathControl, TypeOption.SelectedItem.ToString(), ResolutionOption.SelectedItem.ToString())
        {
            TagText = search_input.Text,
            DownloadPath = DownloadPathControl
        };

        activities.Controls.Add(video_component);
        confirm_download(video_component);
        video_component.Download();
    }
    else
    {
        MessageBox.Show("Debe de colocar una url.", "Advertencia", MessageBoxButtons.OK);
    }
}
```

#### confirm_download 

Esta funcion permite ejecutar en segundo plano si la descarga termino, esto lo podemos determinar si la barra de progreso llego a 100%, despues de eso elimina la actividad.
```C#
private void confirm_download(Video video_component)
{
    Thread confirm_down = new Thread(() =>
    {
        while (true)
        {
            if (video_component.ProgressValue == 100)
            {
                if (activities.InvokeRequired)
                {
                    activities.Invoke(new Action(() =>
                    {
                        if (activities.Controls.Count > 0)
                        {
                            activities.Controls.RemoveAt(0);
                            Search.Enabled = true;
                        }
                    }));
                }
                break;
            }
            Thread.Sleep(100);
        }
    });

    confirm_down.IsBackground = true;
    confirm_down.Start();
}
```