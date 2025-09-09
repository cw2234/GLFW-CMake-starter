cmake_minimum_required(VERSION 3.20)

project(GLFW-CMake-starter)

find_package(OpenGL REQUIRED)

include_directories(${OPENGL_INCLUDE_DIRS})
include_directories("include")

set(GLFW_BUILD_DOCS OFF CACHE BOOL "GLFW lib only")
set(GLFW_INSTALL OFF CACHE BOOL "GLFW lib only")

set(ASSIMP_BUILD_ASSIMP_TOOLS OFF CACHE BOOL "")
set(ASSIMP_BUILD_SAMPLES OFF CACHE BOOL "")
set(ASSIMP_BUILD_TESTS OFF CACHE BOOL "")
set(BUILD_SHARED_LIBS ON CACHE BOOL "")

add_library(MY_LIB src/lib/glad.c src/lib/stb_image.cpp)
# set(
# LIB_FILES 
# src/lib/glad.c 
# src/lib/stb_image.cpp)
add_subdirectory(glfw)

add_subdirectory(assimp)

link_libraries(${OPENGL_LIBRARIES} glfw MY_LIB)
link_libraries(assimp)


file(GLOB CPP_FILES "src/*.cpp")

foreach(CPP_FILE ${CPP_FILES})
    # 提取文件名（不含路径和后缀），作为可执行文件的目标名
    get_filename_component(EXECUTABLE_NAME ${CPP_FILE} NAME_WE)
    # 生成可执行文件：目标名 = 文件名，源文件 = 当前 .cpp 文件
    add_executable(${EXECUTABLE_NAME} ${CPP_FILE})
    
endforeach()

