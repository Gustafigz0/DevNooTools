-- ================================================
-- SCRIPT DE CONFIGURAÇÃO SUPABASE - DevNooTools
-- ================================================
-- Execute este script no SQL Editor do Supabase
-- (Dashboard -> SQL Editor -> New Query)

-- 1. Criar tabela products (se não existir)
CREATE TABLE IF NOT EXISTS public.products (
    id TEXT PRIMARY KEY,
    name TEXT NOT NULL,
    description TEXT,
    price NUMERIC(12,2) DEFAULT 0,
    quantity INTEGER DEFAULT 0,
    created_at TIMESTAMP WITH TIME ZONE DEFAULT NOW(),
    updated_at TIMESTAMP WITH TIME ZONE DEFAULT NOW()
);

-- 2. Habilitar Row Level Security (RLS)
ALTER TABLE public.products ENABLE ROW LEVEL SECURITY;

-- 3. Criar políticas para permitir acesso com anon key
-- (ATENÇÃO: estas políticas são PERMISSIVAS para desenvolvimento/teste)
-- (Em produção, use políticas mais restritivas baseadas em autenticação)

-- Permitir SELECT (leitura) para todos
DROP POLICY IF EXISTS "anon_select_products" ON public.products;
CREATE POLICY "anon_select_products" 
ON public.products 
FOR SELECT 
TO anon
USING (true);

-- Permitir INSERT (inserção) para todos
DROP POLICY IF EXISTS "anon_insert_products" ON public.products;
CREATE POLICY "anon_insert_products" 
ON public.products 
FOR INSERT 
TO anon
WITH CHECK (true);

-- Permitir UPDATE (atualização) para todos
DROP POLICY IF EXISTS "anon_update_products" ON public.products;
CREATE POLICY "anon_update_products" 
ON public.products 
FOR UPDATE 
TO anon
USING (true)
WITH CHECK (true);

-- Permitir DELETE (exclusão) para todos
DROP POLICY IF EXISTS "anon_delete_products" ON public.products;
CREATE POLICY "anon_delete_products" 
ON public.products 
FOR DELETE 
TO anon
USING (true);

-- 4. Criar função para atualizar updated_at automaticamente
CREATE OR REPLACE FUNCTION public.update_updated_at_column()
RETURNS TRIGGER AS $$
BEGIN
    NEW.updated_at = NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- 5. Criar trigger para atualizar updated_at
DROP TRIGGER IF EXISTS update_products_updated_at ON public.products;
CREATE TRIGGER update_products_updated_at
BEFORE UPDATE ON public.products
FOR EACH ROW
EXECUTE FUNCTION public.update_updated_at_column();

-- 6. Verificar se tudo está ok
SELECT 
    'Tabela criada: ' || COUNT(*)::TEXT AS status
FROM information_schema.tables 
WHERE table_schema = 'public' AND table_name = 'products';

-- 7. Listar políticas ativas
SELECT 
    schemaname,
    tablename,
    policyname,
    permissive,
    roles,
    cmd
FROM pg_policies
WHERE tablename = 'products';

-- ================================================
-- TESTE RÁPIDO
-- ================================================
-- Inserir um produto de teste
INSERT INTO public.products (id, name, description, price, quantity)
VALUES ('test-' || gen_random_uuid()::TEXT, 'Produto Teste', 'Descrição teste', 10.50, 5)
ON CONFLICT (id) DO NOTHING;

-- Verificar dados
SELECT * FROM public.products ORDER BY created_at DESC LIMIT 5;

-- ================================================
-- NOTAS IMPORTANTES
-- ================================================
-- 1. A coluna 'id' é TEXT (compatível com GUIDs do C#)
-- 2. RLS está ativado com políticas permissivas para anon
-- 3. Em PRODUÇÃO, configure políticas baseadas em auth.uid()
-- 4. created_at e updated_at são automáticos
-- 5. Se precisar limpar dados de teste:
--    DELETE FROM public.products WHERE name LIKE '%Teste%';
