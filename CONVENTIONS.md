# Backend Conventions

## 1. Naming Conventions
- Use **PascalCase** for class names.
- Prefix interfaces with `I` (e.g., `IRepository`).
- Use **PascalCase** for method names.
- Use **camelCase** for local variables and method parameters.
- Use **UPPER_CASE** with underscores for constants.

## 2. Clean Code Guidelines
- Keep methods small and focused on a single task.
- Use descriptive names for variables, methods, and classes.
- Avoid hardcoding values; use configuration files or constants.
- Handle errors gracefully using try-catch blocks.

## 3. Soft Delete Policy
- Use **Soft Delete** when an entity is **other entities dependent on it**.
- Add an `IsDeleted` or `IsActive` column to the entity.
- Do **not** use Soft Delete for entities that are **no dependent on it** use **hard delete**.

## 4. Code Formatting
- Use **4 spaces** for indentation (no tabs).
- Place opening braces `{` on new line after the declaration.
- Keep lines under **120 characters** for readability.

## 5. Documentation
- Use XML comments to document public methods, classes, and properties.
- Include a `README.md` in every project to describe its purpose and setup.

## 6. Version Control
- Use clear and descriptive commit messages (e.g., `[Feature] Add product search`).
- Use feature branches for new functionality and merge after code review.