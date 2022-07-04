using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Support.Wearable.Activity;
using Android.Support.V7.Widget;
using Android.Widget;
namespace prueba_tarea
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : WearableActivity
    {

        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        PhotoAlbumAdapter mAdapter;
        PhotoAlbum mPhotoAlbum;

        TextView textView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            // Prepare la fuente de datos:
            mPhotoAlbum = new PhotoAlbum();

            // Cree una instancia del adaptador y pasa su fuente de datos:
            mAdapter = new PhotoAlbumAdapter(mPhotoAlbum);

            // Establecer nuestra vista desde el recurso de diseño "principal":
            SetContentView(Resource.Layout.activity_main);

            // Obtiene RecyclerView del diseño.
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // Conecte el adaptador al RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);

            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            //textView = FindViewById<TextView>(Resource.Id.text);
            SetAmbientEnabled();
        }
    }
}