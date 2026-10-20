#!/usr/bin/env python3
"""Preserve Inception's inline decision unions as named reusable schema references."""
import json
import pathlib
import sys

source, destination = map(pathlib.Path, sys.argv[1:])
spec = json.loads(source.read_text())
schemas = spec['components']['schemas']
for model, field, name in [('DecisionRequest', 'questions', 'DecisionQuestion'),
                           ('DecisionResponse', 'answers', 'DecisionAnswer')]:
    value = schemas[model]['properties'][field]['additionalProperties']
    if 'oneOf' not in value or 'discriminator' not in value:
        raise SystemExit(f'Upstream {model}.{field} changed; review decision union normalization')
    if name in schemas:
        raise SystemExit(f'Upstream introduced {name}; review schema normalization')
    schemas[name] = value
    schemas[model]['properties'][field]['additionalProperties'] = {'$ref': '#/components/schemas/' + name}
destination.write_text(json.dumps(spec, indent=2) + '\n')
