

using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TDD.ui {
    public class LifeCurrent : Panel {

        public Label Number;
        public Label Icon;

        //public Image Image;

        public LifeCurrent() {
            //Image = Add.Image( "ui/hud/citizen/citizen.png", "playerimage" );
            Number = Add.Label( "", "number" );
            Icon = Add.Label( "favorite", "icon" );
        }

        public override void Tick() {
            if ( Local.Pawn is not Player pl ) return;

            var life = pl.NumberLife;

            Number.SetClass( "lifelow", life <= 1 );
            Number.Text = $"{life}";

            if ( life <= 1 ) {
                LowHealth();
            }

            if ( life == 3 ) {
                HighHealth();
            }
        }

        public void LowHealth() {
            //Image.SetTexture( "ui/hud/citizen/citizen_low.png" );
        }

        public void HighHealth() {
            //Image.SetTexture( "ui/hud/citizen/citizen.png" );
        }

    }
}
