#version 330 core
out vec4 FragColor;

uniform sampler2D texture1;
in vec2 TexCoords;

void main()
{             
    vec3 col = texture(texture1, TexCoords).rgb;
    float grayscale = 0.2126 * col.r + 0.7152 * col.g + 0.0722 * col.b;
    FragColor = vec4(vec3(grayscale), 1.0);
}