# Sandbox Docker

### Build it
```docker build -t sandbox-thing .```

### Run it
```docker run -v [SolutionFolder]/src:/src sandbox-thing```

### Inspect it
```docker run -v [SolutionFolder]/src:/src -it sandbox-thing bash```
