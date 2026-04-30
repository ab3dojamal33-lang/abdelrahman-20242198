#include "Controller.h"

int main() {
    Post post(1, "My First Post");
    View view;

    Controller controller(&post, &view);

    controller.addComment(1, "Nice post!");
    controller.addComment(2, "Great work!");

    controller.updateView();

    return 0;
}