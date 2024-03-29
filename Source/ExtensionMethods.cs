using Verse;

namespace EdB.PrepareCarefully {
    public static class ExtensionMethods {
        public static void Render(this Pawn pawn) {
            // pawn.Drawer.renderer.graphics.ResolveAllGraphics();
            pawn.Drawer.renderer.renderTree.SetDirty();
            pawn.Drawer.renderer.renderTree.EnsureInitialized((PawnRenderFlags)uint.MaxValue);
        }
    }
}
