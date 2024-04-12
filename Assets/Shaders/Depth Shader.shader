/*
This shader is used to take the depth information from a camera and
render it as grayscale "depth channel" onto a render texture.

Camera depth information itself is not used directly!

This code is Unity's own blend of HLSL (which is like C).
*/
Shader "Custom/DepthShader"
{
    /*
    Properties are inputs to the shader, they will show up in the Unity
    inspector for instance.
    */
    Properties
    {
        /*
        The depth output. The color format should be set to `None` and 
        depth format to something non-zero.
        */
        _MainTex ("Depth Texture (no color)", 2D) = "white" {}
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            sampler2D_float _MainTex;
            float4 _MainTex_ST;

            struct appdata
            {
                // Vertex original position in 3D (4th component is 1.0):
                float4 vertex : POSITION;
            };

            struct v2f {
                float4 vertex : SV_POSITION;
                float2 screenPos : TEXCOORD0;
            };

            // Vertex shader. Runs on each vertex in the 3D scene.
            v2f vert (appdata v)
            {
                v2f o;
    
                // Get the projection of the object coordinate onto the near-clip
                // plane of the camera (= in clip space):
                o.vertex = UnityObjectToClipPos(v.vertex);
    
                // Get position on the screen corresponding to position in clip space
                o.screenPos = ComputeScreenPos(o.vertex);
                return o;
            }

            // Fragment shader. Runs on each pixel to-be rendered on the screen.
            float4 frag (v2f i) : SV_Target
            {
                // Read depth directly from the texture (in the R-channel)
                float depth = tex2D(_MainTex, i.screenPos);
                float4 col;
                col.rgb = depth;
                col.a = 1.0;
                return col;
            }
            ENDCG
        }
    }
}
