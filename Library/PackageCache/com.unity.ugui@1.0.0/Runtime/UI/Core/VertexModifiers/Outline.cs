using UnityEngine.Pool;

namespace UnityEngine.UI
{
<<<<<<< HEAD
    [AddComponentMenu("UI/Effects/Outline", 81)]
=======
    [AddComponentMenu("UI/Effects/Outline", 15)]
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
    /// <summary>
    /// Adds an outline to a graphic using IVertexModifier.
    /// </summary>
    public class Outline : Shadow
    {
        protected Outline()
        {}

        public override void ModifyMesh(VertexHelper vh)
        {
            if (!IsActive())
                return;

            var verts = ListPool<UIVertex>.Get();
            vh.GetUIVertexStream(verts);

            var neededCpacity = verts.Count * 5;
            if (verts.Capacity < neededCpacity)
                verts.Capacity = neededCpacity;

            var start = 0;
            var end = verts.Count;
            ApplyShadowZeroAlloc(verts, effectColor, start, verts.Count, effectDistance.x, effectDistance.y);

            start = end;
            end = verts.Count;
            ApplyShadowZeroAlloc(verts, effectColor, start, verts.Count, effectDistance.x, -effectDistance.y);

            start = end;
            end = verts.Count;
            ApplyShadowZeroAlloc(verts, effectColor, start, verts.Count, -effectDistance.x, effectDistance.y);

            start = end;
            end = verts.Count;
            ApplyShadowZeroAlloc(verts, effectColor, start, verts.Count, -effectDistance.x, -effectDistance.y);

            vh.Clear();
            vh.AddUIVertexTriangleStream(verts);
            ListPool<UIVertex>.Release(verts);
        }
    }
}
