uniform	mat4		WorldMatrix;
uniform	mat4		ViewMatrix;
uniform	mat4		ProjMatrix;

attribute	vec4	position;
attribute	vec4	normal;

varying		vec4	world_position;
varying		vec4	world_normal;
varying		vec4	texcoord0;

void main()
{
	world_position = position * WorldMatrix;
	world_normal = vec4(normal.xyz, 0.0) * WorldMatrix;
	gl_Position = world_position * ViewMatrix;
	gl_Position = gl_Position * ProjMatrix;
gl_Position = position * ProjMatrix;
	texcoord0 = vec4(0, 0, 0, 0);
}



