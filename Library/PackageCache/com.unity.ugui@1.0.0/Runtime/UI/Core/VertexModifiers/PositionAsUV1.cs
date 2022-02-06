using System.Linq;

namespace UnityEngine.UI
{
<<<<<<< HEAD
    [AddComponentMenu("UI/Effects/Position As UV1", 82)]
=======
    [AddComponentMenu("UI/Effects/Position As UV1", 16)]
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
    /// <summary>
    /// An IVertexModifier which sets the raw vertex position into UV1 of the generated verts.
    /// </summary>
    public class PositionAsUV1 : BaseMeshEffect
    {
        protected PositionAsUV1()
        {}

        public override void ModifyMesh(VertexHelper vh)
        {
            UIVertex vert = new UIVertex();
            for (int i = 0; i < vh.currentVertCount; i++)
            {
                vh.PopulateUIVertex(ref vert, i);
                vert.uv1 =  new Vector2(vert.position.x, vert.position.y);
                vh.SetUIVertex(vert, i);
            }
        }
    }
}
