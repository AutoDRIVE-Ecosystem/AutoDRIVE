using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class DepthCamera : MonoBehaviour
{
    /*
    This script simulates a depth camera using GPU acceleration. The camera is set to export
    the depth information in object space, which is captured and sent to the GPU. A custom
    shader `DepthShader` converts this information into grayscale "depth channel" by copying
    the depth information from texture `cameraTexture` onto the provided render texture
    `depthTexture`.
    */

    /// <summary>
    /// Render target texture for the depth camera.
    /// </summary>
    protected RenderTexture cameraTexture;

    /// <summary>
    /// Material holding the `DepthShader` which will apply to the camera output.
    /// The output of the shader is copied to the `depthTexture`.
    /// </summary>
    public Material depthMaterial;

    /// <summary>
    /// Camera capturing the image.
    /// </summary>
    protected Camera depthCamera;

    /// <summary>
    /// Final output texture that will be given out as "depth channel".
    /// </summary>
    public RenderTexture depthTexture;

    void Start()
    {
        // Create a private render texture to grab the camera frame
        this.cameraTexture = new RenderTexture(540, 480, 32, RenderTextureFormat.Depth, 0)
        {
            name = "Depth Texture (Dynamic)",
            depthStencilFormat = GraphicsFormat.D32_SFloat
        };
        // Set camera properties to render depth information
        this.depthCamera = this.GetComponent<Camera>();
        this.depthCamera.depthTextureMode = DepthTextureMode.Depth;
        this.depthCamera.clearFlags = CameraClearFlags.SolidColor;
        this.depthCamera.nearClipPlane = 1.0f;
        this.depthCamera.farClipPlane = 10.0f;
        this.depthCamera.renderingPath = RenderingPath.Forward;
        this.depthCamera.useOcclusionCulling = false;
        this.depthCamera.allowHDR = false;
        this.depthCamera.allowMSAA = false;
        // Set render target texture for the depth camera
        depthCamera.targetTexture = this.cameraTexture;
    }

    void Update()
    {
        // Camera is disabled, manually trigger the render instead
        depthCamera.Render();
        // Uses the shader from `depthMaterial` to copy the pixel data from a `cameraTexture` into a render `depthTexture`.
        // This method copies pixel data from a texture on the GPU to a render texture on the GPU.
        // This is one of the fastest ways to copy a texture.
        Graphics.Blit(this.cameraTexture, this.depthTexture, this.depthMaterial);
    }

}
